using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Class
{
	public class ReservationManagement
	{
		private static DBConnection dBConnection = new DBConnection();
		public bool MakeReservation(int itemId, int accountId, DateTime StartDate)
		{
			DateTime endDate = StartDate.AddDays(7);

			MySqlCommand command = new MySqlCommand();
			command.CommandText = "INSERT INTO `reservation`(`itemID`, `AccountID`, `StartDate`, `Enddate`) VALUES (@item,@account,@startDate,@endDate)";
			command.Parameters.Add(new MySqlParameter("@item", itemId));
			command.Parameters.Add(new MySqlParameter("@account", accountId));
			command.Parameters.Add(new MySqlParameter("@startDate", StartDate));
			command.Parameters.Add(new MySqlParameter("@endDate", endDate));

			return dBConnection.ExecuteNoNQuery(command);
		}

		public static void DeleteReservation(int id)
		{
			throw new NotImplementedException();
		}

		public bool ExtendReservation(int reservationId)
		{
			throw new NotImplementedException();
		}

		public List<Reservation> GetReservations()
		{
			throw new NotImplementedException();
		}

		public List<Reservation> GetReservation(int accountId)
		{
			throw new NotImplementedException();
		}
	}
}
