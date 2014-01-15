using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemberRegistry
{
    public class MemberRegistry
    {
        public List<Member> MemberList { get; set; }
        public string FilePath { get; set; }

        public MemberRegistry()
        {
            MemberList = new List<Member>();
        }

        public void Load(string file)
        {
            FilePath = file;
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    MemberList.Add(new Member(parts[0], parts[1], parts[2], int.Parse(parts[3]))); // kan behöva felhantering, finns ingen garanti att det sista värdet är en siffra.
                }
            }
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Member member in MemberList)
                {
                    writer.WriteLine("{0},{1},{2},{3}", member.FirstName, member.LastName, member.TelephoneNumber, member.IdNumber);
                }
            }
        }
    }
}
