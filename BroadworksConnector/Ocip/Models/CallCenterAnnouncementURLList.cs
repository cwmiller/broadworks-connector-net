using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains list of urls
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:894""}]")]
    public class CallCenterAnnouncementURLList
    {

        private string _url1;

        [XmlElement(ElementName = "url1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:894")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Url1
        {
            get => _url1;
            set
            {
                Url1Specified = true;
                _url1 = value;
            }
        }

        [XmlIgnore]
        protected bool Url1Specified { get; set; }

        private string _url2;

        [XmlElement(ElementName = "url2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:894")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Url2
        {
            get => _url2;
            set
            {
                Url2Specified = true;
                _url2 = value;
            }
        }

        [XmlIgnore]
        protected bool Url2Specified { get; set; }

        private string _url3;

        [XmlElement(ElementName = "url3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:894")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Url3
        {
            get => _url3;
            set
            {
                Url3Specified = true;
                _url3 = value;
            }
        }

        [XmlIgnore]
        protected bool Url3Specified { get; set; }

        private string _url4;

        [XmlElement(ElementName = "url4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:894")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Url4
        {
            get => _url4;
            set
            {
                Url4Specified = true;
                _url4 = value;
            }
        }

        [XmlIgnore]
        protected bool Url4Specified { get; set; }

    }
}
