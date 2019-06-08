using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtendedFileResource 
{
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _file;

    [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource File {
        get => _file;
        set {
            FileSpecified = true;
            _file = value;
        }
    }

    [XmlIgnore]
    public bool FileSpecified { get; set; }
    private string _url;

    [XmlElement(ElementName = "url", IsNullable = true, Namespace = "")]
    public string Url {
        get => _url;
        set {
            UrlSpecified = true;
            _url = value;
        }
    }

    [XmlIgnore]
    public bool UrlSpecified { get; set; }
}
}
