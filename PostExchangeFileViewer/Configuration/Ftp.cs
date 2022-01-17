using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostExchangeFileViewer.Configuration {
    [DataContract]
    public class Ftp {
        /// <summary>
        /// FTP сервер с файлами 1С
        /// </summary>
        [DataMember]
        public string Host { get; set; }

        /// <summary>
        /// Имя пользователя сервера FTP
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Пароль пользователя сервера FTP
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Папка FTP
        /// </summary>
        [DataMember]
        public string Cwd { get; set; }


        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context) {
            Cwd = (Cwd == null) ? string.Empty : Cwd;
            Cwd = Cwd.EndsWith("/") ? Cwd : (Cwd + "/");
        }
    }
}
