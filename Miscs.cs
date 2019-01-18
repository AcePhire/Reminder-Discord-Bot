[Command("setreminder")]
        public async Task Reminder(string reminder, string day, string time = null)
        {
            if (time == null)
            {
                time = day;
                day = "Today";
            }
            string[] hourAndMinutes = time.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            int hour = int.Parse(hourAndMinutes[0]);
            int minutes = int.Parse(hourAndMinutes[1]);

            var account = UserAccounts.GetAccount(Context.User);
            account.reminder = reminder;
            account.dayAndTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + Utilities.CheckHowManyDaysLeft(day), hour, minutes, 0);
            UserAccounts.SaveAccount();

            var embed = new EmbedBuilder();
            embed.WithTitle(":white_check_mark: Reminder Saved! :white_check_mark:");
            embed.AddField("Reminder: ", reminder, true);
            embed.AddField("Day: ", Utilities.ChangeLetterToUpperCase(day, 0), true);
            embed.AddField("Time: ", hour + ":" + minutes, true);
            embed.AddField("AllInOne: ", account.dayAndTime, true);
            Random rand = new Random();
            embed.WithColor(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

            await Context.Channel.SendMessageAsync("", embed: embed.Build());

        }
