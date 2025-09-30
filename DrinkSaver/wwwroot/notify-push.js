window.blazorNotify = {
    show: async function (title, body) {
        if (!("Notification" in window)) return;
        if (Notification.permission === "granted") {
            new Notification(title, { body: body });
            return;
        }
        if (Notification.permission !== "denied") {
            const permission = await Notification.requestPermission();
            if (permission === "granted") {
                new Notification(title, { body: body });
            }
        }
    }
};
