using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorder the charging function element servers. You can not add or delete addresses,
    /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
    /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SystemAccountingGetChargingFunctionElementServerListRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2095""}]")]
    public class SystemAccountingReorderChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<string> _orderedAddressList = new List<string>();

        [XmlElement(ElementName = "orderedAddressList", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2095")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> OrderedAddressList
        {
            get => _orderedAddressList;
            set
            {
                OrderedAddressListSpecified = true;
                _orderedAddressList = value;
            }
        }

        [XmlIgnore]
        protected bool OrderedAddressListSpecified { get; set; }

    }
}
