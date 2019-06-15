using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains list of urls
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterAnnouncementURLList 
    {

        
        private string _url1;

        [XmlElement(ElementName = "url1", IsNullable = false, Namespace = "")]
        public string Url1 {
            get => _url1;
            set {
                Url1Specified = true;
                _url1 = value;
            }
        }

        [XmlIgnore]
        public bool Url1Specified { get; set; }
        
        private string _url2;

        [XmlElement(ElementName = "url2", IsNullable = false, Namespace = "")]
        public string Url2 {
            get => _url2;
            set {
                Url2Specified = true;
                _url2 = value;
            }
        }

        [XmlIgnore]
        public bool Url2Specified { get; set; }
        
        private string _url3;

        [XmlElement(ElementName = "url3", IsNullable = false, Namespace = "")]
        public string Url3 {
            get => _url3;
            set {
                Url3Specified = true;
                _url3 = value;
            }
        }

        [XmlIgnore]
        public bool Url3Specified { get; set; }
        
        private string _url4;

        [XmlElement(ElementName = "url4", IsNullable = false, Namespace = "")]
        public string Url4 {
            get => _url4;
            set {
                Url4Specified = true;
                _url4 = value;
            }
        }

        [XmlIgnore]
        public bool Url4Specified { get; set; }
        
    }
}
