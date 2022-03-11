using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // В ПРОВЕРКАХ НЕТ ПРОВЕРКИ НА КОЛИЧЕСТВО ЦИФР В ПОРТУ И В IP, НЕ ПРОВЕРЕН СЕРВИС
    // - tests

    public static class URI
    {
        public static string prefix = "http";
        public static string ip = "10.10.13.94";
        public static string port = "8888";
        public static readonly string port_my = "8888";
        public static string service = "IContract";

        static string example = "http://10.10.13.94:4000/IContract";

        public static string form_uri()
        {
            string p = form_uri(prefix, ip, port, service);

            return p;
        }

        public static string form_uri(string Prefix, string Ip, string Port, string Service)
        {
            string p = $"{Prefix}://{Ip}:{Port}/{Service}";

            return p;
        }

        public static bool check_uri()
        {
            bool checkushki = true;



            return checkushki;
        }

        private static bool check_prefix(string pr)
        {
            bool good = true;

            if (string.IsNullOrWhiteSpace(pr))
                good = false;
            else if(pr!= "http"|| pr != "https")
                good = false;

            return good;
        }

        private static bool check_ip(string p)
        {
            bool good = true;

            string [] parts = p.Split('.');
            
            if (parts.Length != 4)
                good = false;

            foreach (string part in parts)
                if (!int.TryParse(part, out int value)){
                    good = false;
                    break;
                }

            return good;
        }

        private static bool check_port(string por)
        {
            bool good = true;

            if (!int.TryParse(por, out int value))
                good = false;

            return good;
        }

    }
}
