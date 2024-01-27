using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deletes a Mcc/Mnc home network.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4489f4baeefa41b8df0a86def4c05cd8:119""}]")]
    public class SystemMccMncHomeNetworkDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _homeNetworkMccMnc;

        [XmlElement(ElementName = "homeNetworkMccMnc", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:119")]
        [MinLength(5)]
        [MaxLength(6)]
        public string HomeNetworkMccMnc
        {
            get => _homeNetworkMccMnc;
            set
            {
                HomeNetworkMccMncSpecified = true;
                _homeNetworkMccMnc = value;
            }
        }

        [XmlIgnore]
        protected bool HomeNetworkMccMncSpecified { get; set; }

    }
}
