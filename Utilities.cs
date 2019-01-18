public static int CheckHowManyDaysLeft(string dayInString)
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            if (dayInString == "Today" || dayInString == "today") day = DateTime.Now.DayOfWeek;
            if (dayInString == "Tomorrow" || dayInString == "tomorrow") day = DateTime.Now.DayOfWeek + 1;
            if (dayInString == "AfterTomorrow" || dayInString == "afterTomorrow" || dayInString == "Aftertomorrow" || dayInString == "aftertomorrow") day = DateTime.Now.DayOfWeek + 2;
            if (dayInString == "Sunday" || dayInString == "sunday") day = DayOfWeek.Sunday;
            if (dayInString == "Monday" || dayInString == "monday") day = DayOfWeek.Monday;
            if (dayInString == "Tuesday" || dayInString == "tuesday") day = DayOfWeek.Tuesday;
            if (dayInString == "Wednesday" || dayInString == "wednesday") day = DayOfWeek.Wednesday;
            if (dayInString == "Thursday" || dayInString == "thursday") day = DayOfWeek.Thursday;
            if (dayInString == "Friday" || dayInString == "friday") day = DayOfWeek.Friday;
            if (dayInString == "Saturday" || dayInString == "saturday") day = DayOfWeek.Saturday;

            if (day == DateTime.Now.DayOfWeek) return 0;
            if (day == DateTime.Now.DayOfWeek + 1) return 1;
            if (day == DateTime.Now.DayOfWeek + 2) return 2;
            if (day == DateTime.Now.DayOfWeek + 3) return 3;
            if (day == DateTime.Now.DayOfWeek + 4) return 4;
            if (day == DateTime.Now.DayOfWeek + 5) return 5;
            if (day == DateTime.Now.DayOfWeek + 6) return 6;

            return 0;
        }
