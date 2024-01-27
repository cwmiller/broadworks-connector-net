using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export all users that have BroadCloud services, such as
    /// user profile information and BroadCloud services related information for that user
    /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10067""}]")]
    public class SystemExportBroadCloudDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10067")]
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
