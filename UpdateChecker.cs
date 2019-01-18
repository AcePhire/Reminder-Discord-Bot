private static Timer loopingTimer;
        private static SocketTextChannel channel = Global.Client.GetGuild("").DefaultChannel;
        internal static Task StartTimer()
        {
            loopingTimer = new Timer
            {
                Interval = 60000,
                AutoReset = true,
                Enabled = true
            };

            loopingTimer.Elapsed += CheckForReminder; ;

            return Task.CompletedTask;
        }

private static async void CheckForReminder(object sender, ElapsedEventArgs e)
        {
            foreach (var user in UserAccounts.UserAccounts.accounts)
            {
                if (user.reminder != null)
                {
                    if (user.dayAndTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute - 1, DateTime.Now.Second)
                        && user.dayAndTime <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute + 1, DateTime.Now.Second))
                    {
                        user.reminder = null;
                        await channel.SendMessageAsync(channel.GetUser(user.ID).Mention + " its time to " + user.reminder);
                    }
                }
            }
        }
