using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify which OCI Call Control Applications are enabled on a user
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2700""}]")]
    public class UserOCICallControlApplicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2700")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList _applicationIdList;

        [XmlElement(ElementName = "applicationIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2700")]
        public BroadWorksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList ApplicationIdList
        {
            get => _applicationIdList;
            set
            {
                ApplicationIdListSpecified = true;
                _applicationIdList = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationIdListSpecified { get; set; }

    }
}
