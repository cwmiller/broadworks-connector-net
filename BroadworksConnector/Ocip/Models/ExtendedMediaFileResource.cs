using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either an existing file for the application server to use, or
    /// the contents of a file to transfer and an URL.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2299""}]")]
    public class ExtendedMediaFileResource
    {

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2299")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File
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
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2299")]
        [MinLength(1)]
        [MaxLength(256)]
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
