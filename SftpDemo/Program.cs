using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SftpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //upload sftp 
            using (SftpClient client = new SftpClient(new PasswordConnectionInfo("192.168.1.102", "tester", "password")))
            { client.Connect(); }
        }
    }
}
