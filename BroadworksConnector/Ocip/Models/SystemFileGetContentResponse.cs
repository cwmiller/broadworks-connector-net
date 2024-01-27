using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemFileGetContentRequest. The fileContent length returned is limited to 128KBytes.
    /// <see cref="SystemFileGetContentRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10352""}]")]
    public class SystemFileGetContentResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _fileContent;

        [XmlElement(ElementName = "fileContent", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10352")]
        public string FileContent
        {
            get => _fileContent;
            set
            {
                FileContentSpecified = true;
                _fileContent = value;
            }
        }

        [XmlIgnore]
        protected bool FileContentSpecified { get; set; }

    }
}
