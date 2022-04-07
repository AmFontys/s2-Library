using Library_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Class
{
	public class ScheduleManagement
	{
		public void NewSchedule(int workerId, DateTime scheduleDate, TimeSpan beginHour, TimeSpan endHour)
		{
			throw new NotImplementedException();
		}

		public void ChangeSchedule(int scheduleId, int workerId, TimeSpan beginHour, TimeSpan endHour)
		{
			throw new NotImplementedException();
		}

		public static void DeleteSchedule(int id)
		{
			throw new NotImplementedException();
		}

		public List<Schedule> GetAllSchedules()
		{
			throw new NotImplementedException();
		}

		public List<Schedule> GetAllSchedules(int accountId)
		{
			throw new NotImplementedException();
		}
	}
}
