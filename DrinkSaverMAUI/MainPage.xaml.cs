using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using DrinkSaverMAUI.Helper;
using DrinkSaverMAUI.Interfaces;

namespace DrinkSaverMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(INotificationService notificationService)
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(notificationService);
        }
    }

    [SuppressMessage("ReSharper", "AsyncVoidLambda")]
    public class MainPageViewModel : BindableObject
    {
        // Fields
        public string NextRunDisplay => _nextRun?.ToString("HH:mm:ss dd.MM.yyyy") ?? "—";
        
        public string StatusText => _isRunning ? $"Läuft — Intervall {IntervalMinutes} Min" : "Gestoppt";
        
        public int IntervalMinutes
        {
            get => _intervalMinutes;
            set
            {
                _intervalMinutes = Math.Max(1, value);
                OnPropertyChanged();
                CalculateNextRun();
            }
        }

        public bool AlignToClock
        {
            get => _alignToClock;
            set
            {
                _alignToClock = value;
                OnPropertyChanged();
                CalculateNextRun();
            }
        }
        
        // Variables
        private int _intervalMinutes = 20;
        private bool _alignToClock = true;
        private DateTime? _nextRun;
        private bool _isRunning = false;
        
        // Interfaces
        private readonly INotificationService _notificationService;

        // Commands
        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand TriggerNowCommand { get; }
        public ICommand ListScheduledCommand { get; }
        public ICommand CancelAllCommand { get; }
        
        public MainPageViewModel(INotificationService notificationService)
        {
            _notificationService = notificationService;

            StartCommand = new Command(async () => await StartAsync());
            StopCommand = new Command(async () => await StopAsync());
            TriggerNowCommand = new Command(async () => await TriggerNowAsync());
            ListScheduledCommand = new Command(async () => await ShowScheduledAsync());
            CancelAllCommand = new Command(async () => await CancelAllAsync());
            
            CalculateNextRun();
        }

        void CalculateNextRun()
        {
            try
            {
                var now = DateTime.Now;

                if (!AlignToClock)
                {
                    _nextRun = now.AddMinutes(IntervalMinutes);
                }
                else
                {
                    int i = Math.Max(1, IntervalMinutes);

                    if (now.Minute % i == 0 && now.Second == 0)
                    {
                        _nextRun = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
                    }
                    else
                    {
                        int nextBoundary = ((now.Minute / i) + 1) * i;
                        if (nextBoundary >= 60)
                            _nextRun = new DateTime(now.Year, now.Month, now.Day, now.Hour, 0, 0).AddHours(1);
                        else
                            _nextRun = new DateTime(now.Year, now.Month, now.Day, now.Hour, nextBoundary, 0);
                    }
                }
            }
            catch
            {
                _nextRun = null;
            }

            OnPropertyChanged(nameof(NextRunDisplay));
        }

        public async Task StartAsync()
        {
            bool permissionGranted = await NotificationPermissionHelper.RequestNotificationPermissionAsync();

            if (!permissionGranted)
                return;
            
            _isRunning = true;
            CalculateNextRun();
            var start = _nextRun ?? DateTime.MaxValue;
            var interval = TimeSpan.FromMinutes(IntervalMinutes);
            await _notificationService.ScheduleRepeatingAsync(start, interval, "Erinnerung", "Wasser trinken", 42);
            await Application.Current.MainPage.DisplayAlert("Erstellt", "Erinnerung wurde geplant", "Okay");
        }

        public async Task StopAsync()
        {
            _isRunning = false;
            await _notificationService.CancelAsync(42);
            await Application.Current.MainPage.DisplayAlert("Abgebrochen", "Erinnerung wurde abgebrochen", "Okay");
        }

        public async Task TriggerNowAsync()
        {
            bool permissionGranted = await NotificationPermissionHelper.RequestNotificationPermissionAsync();

            if (!permissionGranted)
                return;
            
            var start = DateTime.Now.AddSeconds(10); // Starte in 1s zum Testen
            var interval = TimeSpan.FromMinutes(IntervalMinutes);
            await _notificationService.ScheduleRepeatingAsync(start, interval, "Erinnerung", "Wasser trinken", 42);
            await Application.Current.MainPage.DisplayAlert("Erstellt", "Erinnerung wurde geplant", "Okay");
        }

        public async Task ShowScheduledAsync()
        {
            try
            {
                string text = "Keine geplanten Benachrichtigungen";

                await Application.Current.MainPage.DisplayAlert("Geplante Notifications", text, "Okay");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Fehler", ex.Message, "Okay");
            }
        }
        
        public async Task CancelAllAsync()
        {
            await _notificationService.CancelAsync(42);
            await Application.Current.MainPage.DisplayAlert("Abgebrochen", "Erinnerung wurde abgebrochen", "Okay");
        }
    }
}