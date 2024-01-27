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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:1953""}]")]
    public class GroupBroadWorksAnywhereGetInstanceRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupBroadWorksAnywhereGetInstanceResponse17>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1953")]
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
