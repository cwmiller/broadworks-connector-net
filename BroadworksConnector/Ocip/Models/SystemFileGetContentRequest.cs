using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the contents of a file.  This transaction is only allowed to get content for files under
    /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
    /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
    /// <see cref="SystemFileGetContentResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10337""}]")]
    public class SystemFileGetContentRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemFileGetContentResponse>
    {

        protected string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10337")]
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
