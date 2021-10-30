using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to configure a WebEx room/place to have the primary endpoint of WebEx Teams device.
    /// 
    /// placeUserId refers to a WebEx room/place.
    /// webExSIPAddress specifies the WebEx SIP address of the place. The format of this parameter is: user@domain.
    /// The user part specified in webExSIPAddress will be set to the lineport of the place’s primary endpoint. The endpoint
    /// will have a static address with URI set to "sip:user@domain".
    /// The domain specified in webExSIPAddress will be:
    /// - added to the system if it does not exist yet.
    /// - assigned to the service provider/enterprise which the place belongs to, if it has not been assigned yet.
    /// - assigned to the group which the place belongs to, if it has not been assigned yet.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:155""}]")]
    public class PlaceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _placeUserId;

        [XmlElement(ElementName = "placeUserId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:155")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PlaceUserId
        {
            get => _placeUserId;
            set
            {
                PlaceUserIdSpecified = true;
                _placeUserId = value;
            }
        }

        [XmlIgnore]
        protected bool PlaceUserIdSpecified { get; set; }

        private string _webExSIPAddress;

        [XmlElement(ElementName = "webExSIPAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:155")]
        [MinLength(1)]
        [MaxLength(161)]
        public string WebExSIPAddress
        {
            get => _webExSIPAddress;
            set
            {
                WebExSIPAddressSpecified = true;
                _webExSIPAddress = value;
            }
        }

        [XmlIgnore]
        protected bool WebExSIPAddressSpecified { get; set; }

    }
}
