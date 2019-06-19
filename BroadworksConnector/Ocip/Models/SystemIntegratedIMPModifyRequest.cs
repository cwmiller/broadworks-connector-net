using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system Integrated IMP service attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// boshURL
    /// allowImpPasswordRetrieval
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:296""}]")]
    public class SystemIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:296")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        public bool ServiceDomainSpecified { get; set; }

        private int? _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:296")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? ServicePort
        {
            get => _servicePort;
            set
            {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        public bool ServicePortSpecified { get; set; }

        private bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:296")]
        public bool AddServiceProviderInIMPUserId
        {
            get => _addServiceProviderInIMPUserId;
            set
            {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        public bool AddServiceProviderInIMPUserIdSpecified { get; set; }

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:296")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BoshURL
        {
            get => _boshURL;
            set
            {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        public bool BoshURLSpecified { get; set; }

        private bool _allowImpPasswordRetrieval;

        [XmlElement(ElementName = "allowImpPasswordRetrieval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:296")]
        public bool AllowImpPasswordRetrieval
        {
            get => _allowImpPasswordRetrieval;
            set
            {
                AllowImpPasswordRetrievalSpecified = true;
                _allowImpPasswordRetrieval = value;
            }
        }

        [XmlIgnore]
        public bool AllowImpPasswordRetrievalSpecified { get; set; }

    }
}
