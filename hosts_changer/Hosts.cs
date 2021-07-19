using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hosts_changer
{
    class Hosts
    {
        private static readonly Lazy<Hosts>
        lazy =
        new Lazy<Hosts>
            (() => new Hosts());

        public static Hosts Instance { get { return lazy.Value; } }


        //private const string filePath = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private const string filePath = "C:\\hosts.txt";

        private List<string> _commentLines = new List<string>();
        public List<string> CommentLines
        {
            get => _commentLines;
        }

        private List<HostRecord> _hostRecords = new List<HostRecord>();
        public List<HostRecord> HostRecords
        {
            get => _hostRecords;
        }


        private Hosts()
        {
        }


        public void GetData()
        {
            StreamReader obFile = new StreamReader(filePath);

            _commentLines.Clear();
            _hostRecords.Clear();

            while (!obFile.EndOfStream)
            {
                string s = obFile.ReadLine();
                s = s.Trim(' ');
                
                if (s.Length > 0)
                {
                    if (s[0] == '#')
                    {
                        _commentLines.Add(s);
                    }
                    else
                    {
                        foreach (Match match in Regex.Matches(s, @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\s+([^#\n\r]+)", RegexOptions.IgnoreCase))
                        {
                            _hostRecords.Add(new HostRecord(match.Groups[1].Value.Trim(' '), match.Groups[2].Value.Trim(' ')));
                        }
                    }
                }
            }

            obFile.Close();
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Created by HostsChanger");
            }

            CommentLines.ForEach(value => this.WriteLine(value));

            HostRecords.ForEach(delegate (HostRecord record) {
                if (record.Ip.Length > 0 && record.Domain.Length > 0)
                {
                    this.WriteLine(record.Ip + " " + record.Domain);
                }
            });
        }

        public void WriteLine(string text)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }

    class HostRecord
    {
        private string _ip;
        public string Ip
        {
            get => _ip;
            set => _ip = value;
        }

        private string _domain;
        public string Domain
        {
            get => _domain;
            set => _domain = value;
        }

        public HostRecord(string ip, string domain)
        {
            _ip = ip;
            _domain = domain;
        }
    }
}
