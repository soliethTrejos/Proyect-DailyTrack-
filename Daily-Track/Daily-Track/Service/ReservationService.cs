using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daily_Track.Models;

namespace Daily_Track.Service
{
    public class ReservationService
    {
        private readonly string filePath = "reservations.bin";

        public void SaveReservation(Reservation reservation)
        {
            List<Reservation> reservations = GetAllReservations();
            reservations.Add(reservation);
            SaveToFile(reservations);
        }

        public List<Reservation> GetAllReservations()
        {
            if (!File.Exists(filePath))
                return new List<Reservation>();

            List<Reservation> reservations = new List<Reservation>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    Reservation reservation = new Reservation
                    {
                        Id = reader.ReadInt32(),
                        Name = reader.ReadString(),
                        Career = reader.ReadString(),
                        CreditCancellation = reader.ReadString()
                    };
                    reservations.Add(reservation);
                }
            }
            return reservations;
        }

        private void SaveToFile(List<Reservation> reservations)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (Reservation reservation in reservations)
                {
                    writer.Write(reservation.Id);
                    writer.Write(reservation.Name);
                    writer.Write(reservation.Career);
                    writer.Write(reservation.CreditCancellation);
                }
            }

        }
    }
}
