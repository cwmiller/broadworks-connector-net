using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ExtendedMediaFileResource20
    {
        private BroadworksConnector.Ocip.Models.AnnouncementFileKey _file;

        [XmlElement(ElementName = "file", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementFileKey File
        {
            get => _file;
            set
            {
                FileSpecified = true;
                _file = value;
            }
        }

        [XmlIgnore]
        public bool FileSpecified { get; set; }
        private string _url;

        [XmlElement(ElementName = "url", IsNullable = true, Namespace = "")]
        public string Url
        {
            get => _url;
            set
            {
                UrlSpecified = true;
                _url = value;
            }
        }

        [XmlIgnore]
        public bool UrlSpecified { get; set; }
    }
}
