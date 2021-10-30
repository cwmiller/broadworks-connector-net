using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a BroadWorks Anywhere instance.
    /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
    /// 
    /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
    /// <see cref="GroupBroadWorksAnywhereGetInstanceResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupBroadWorksAnywhereGetInstanceRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1446""}]")]
    public class GroupBroadWorksAnywhereGetInstanceRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupBroadWorksAnywhereGetInstanceResponse17>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1446")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
