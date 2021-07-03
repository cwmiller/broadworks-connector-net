using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2444""}]")]
    public class SystemAuthenticationLockoutExportDataGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2444")]
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
