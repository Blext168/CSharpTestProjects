self.addEventListener('push', function (event) {
    let payload = { title: 'Benachrichtigung', body: 'Sie haben eine neue Nachricht' };
    if (event.data) {
        try {
            payload = event.data.json();
        } catch (e) {
            payload = { title: 'Benachrichtigung', body: event.data.text() };
        }
    }

    const options = {
        body: payload.body,
        tag: 'interval-notification',
        renotify: true,
        timestamp: Date.now()
    };

    event.waitUntil(self.registration.showNotification(payload.title, options));
});

self.addEventListener('notificationclick', function(event) {
    event.notification.close();
    event.waitUntil(clients.openWindow('/'));
});
