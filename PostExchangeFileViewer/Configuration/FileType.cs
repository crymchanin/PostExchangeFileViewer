using System.Drawing;
using System.Runtime.Serialization;


namespace PostExchangeFileViewer.Configuration {
    [DataContract]
    public class FileType {
        /// <summary>
        /// Тип файла
        /// </summary>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Описание типа файла
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Цвет строки при отображаении типа файла
        /// </summary>
        [DataMember]
        public string RowColor { get; set; }
    }
}
