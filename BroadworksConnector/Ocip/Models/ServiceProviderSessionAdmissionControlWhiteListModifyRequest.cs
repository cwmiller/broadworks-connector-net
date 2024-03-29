using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Service Provider Session Admission Control White List information.
    /// The number of digit pattern entries is limited to 100.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6796""}]")]
    public class ServiceProviderSessionAdmissionControlWhiteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6796")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected List<string> _addMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6796")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> AddMatchDigitPattern
        {
            get => _addMatchDigitPattern;
            set
            {
                AddMatchDigitPatternSpecified = true;
                _addMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool AddMatchDigitPatternSpecified { get; set; }

        protected List<string> _deleteMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6796")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DeleteMatchDigitPattern
        {
            get => _deleteMatchDigitPattern;
            set
            {
                DeleteMatchDigitPatternSpecified = true;
                _deleteMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteMatchDigitPatternSpecified { get; set; }

        protected bool _enableWhiteList;

        [XmlElement(ElementName = "enableWhiteList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6796")]
        public bool EnableWhiteList
        {
            get => _enableWhiteList;
            set
            {
                EnableWhiteListSpecified = true;
                _enableWhiteList = value;
            }
        }

        [XmlIgnore]
        protected bool EnableWhiteListSpecified { get; set; }

    }
}
