using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
    /// to a file so they can be uploaded to a Network Server.
    /// In XS data mode, response is sent without waiting for completion.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9931""}]")]
    public class SystemExportAddressingDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9931")]
        [MinLength(1)]
        public string FileName
        {
            get => _fileName;
            set
            {
                FileNameSpecified = true;
                _fileName = value;
            }
        }

        [XmlIgnore]
        protected bool FileNameSpecified { get; set; }

    }
}
