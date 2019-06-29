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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9205""}]")]
    public class SystemFileGetContentResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _fileContent;

        [XmlElement(ElementName = "fileContent", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9205")]
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
