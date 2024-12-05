using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daily_Track.Models;

namespace Daily_Track.Service
{
    public class UsernameService
    {
        private readonly string filePath = "usernames.bin";

        public void SaveUsername(username user)
        {
            List<username> users = GetAllUsernames();
            users.Add(user);
            SaveToFile(users);
        }

        public List<username> GetAllUsernames()
        {
            if (!File.Exists(filePath))
                return new List<username>();

            List<username> users = new List<username>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    username user = new username
                    {
                        Id = reader.ReadInt32(),
                        Name = reader.ReadString(),
                        Password = reader.ReadString()
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        private void SaveToFile(List<username> users)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (username user in users)
                {
                    writer.Write(user.Id);
                    writer.Write(user.Name);
                    writer.Write(user.Password);
                }
            }
        }
    }
}
