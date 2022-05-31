# Changelog

## [2.1.2] - 2022-05-31
### Fixed
- Fixed issue where `Validator` was not validating parent properties inheritted by sub-classes.

## [2.1.1] - 2022-01-22
### Fixed
- Fixed issue where `ErrorResponseException` and `LoginException` were not being thrown on error.

## [2.1.0] - 2021-12-18
### Changed
- Adjusted models for TIII-81498 which adds customerId and secretKey fields to the Third-Party Emergency Calling service at SP/Ent/Group levels.

## [2.0.1] - 2021-11-20
### Fixed
- Fixed exception being thrown by `Validator` when a nillable property was set to null.

## [2.0.0] - 2021-11-20
### Changed
- `CallAsync` now infers the response type for a request instead of just returning the `OCICommand` base type.
- `CallAllAsync` now returns a `BatchResult` object which can be iterated on like previously, but also has a `Get` method for retrieving the response for a specific request.
- Exceptions occuring within `TcpTransport` are no longer caught and wrapped in `BadResponseException`.

### Removed
- All of the per-request methods have been removed in favor of using `CallAsync` for all requests.

### Added
- Added interface `IOcipClient` which `OcipClient` implements.

## [1.4.0] - 2021-07-04
### Changed
- Updated all models using `Rel_24.0_1.944` schema files.

## [1.3.0] - 2021-03-27
### Added
- Added options to `OcipClientOptions` to adjust the request and response text encoding used by the TCP transport. [@Rogn](https://github.com/Rogn)
- Added locks to prevent concurrency issues.

## [1.2.1] - 2020-12-13
### Fixed
- Fixed response type for GroupCallCenterStrandedCallUnavailableGetRequest20

## [1.2.0] - 2020-07-22
### Added
- Added properties to `OcipClientOptions` to control timeouts for both SOAP and TCP transports.

## [1.1.0] - 2020-06-28
### Changed
- All async methods have been renamed to include an "Async" suffix. The previous names are still usable, but are marked as deprecated and will be removed in the next major release.
- Improved uniqueness of generated session IDs by basing it around a GUID instead of the current time.

### Added
- Cancellation tokens are now supported and can be passed to the new "Async" methods.

## [1.0.3] - 2020-05-14
### Fixed
- Fixed issue with `AttributeUtil` throwing an exception if its cache is accessed by mutiple instances of `OcipClient` simultaneously.

## [1.0.2] - 2020-04-11
### Fixed
- Fixed issue with serialized XML not including the xsi:type attribute for abstract properties when they have been set to NULL.

## [1.0.1] - 2019-12-24
### Fixed
- Fixed issue with enum lists not being recognized as a list by the `Serializer` or `Validator`.

## [1.0.0] - 2019-12-15

## [0.5.5-alpha] - 2019-12-05
### Fixed
- Fixed issue with `TcpTransport` that could cause a timeout when reading from server.

## [0.5.4-alpha] - 2019-09-02
### Fixed
- HTTP now actually fixed

## [0.5.3-alpha] - 2019-09-02
### Fixed
- Fixed SOAP transport always treating the connection as HTTPS even when an HTTP URL is given to it.

## [0.5.2-alpha] - 2019-08-19
### Fixed
- `SuccessResponse` responses were causing an exception

## [0.5.1-alpha] - 2019-07-26
### Fixed
- Fixed R22 login

## [0.5.0-alpha] - 2019-07-23
### Changed
- `Validator.Validate` now returns a `ValidationResult` object instead of throwing a child of `ValidationException`. The `Success` property is true if the object passed all validation checks. If not successful, the `Errors` property contains a list of all errors.
- `ValidationException` is no longer abstract and is what is thrown by `OcipClient` when validation fails.
- Sequences that are part of choices are now validated if at least one property is set on the sequence.
- Choice error messages now include the list of properties that make up the choice.

### Fixed
- Choice groups were not properly determining when a sequence property was set.

## [0.4.2-alpha] - 2019-07-01
### Fixed
- Fixed issue where an ErrorResponse from the server would trigger a BadResponseException instead of an ErrorResponseException.

## [0.4.1-alpha] - 2019-06-30
### Fixed
- Fixed issue with all calls failing due to calling `Validator.Validate` on an list.
- Fixed issue with deserializing child object types.

## [0.4.0-alpha] - 2019-06-30
### Changed
- Serialization is now handled by a custom `Serializer` class instead of relying on `System.Xml.Serialization.XmlSerializer`. This has several benefits including much greater performance.
- The *PropertyName*Specified properties which are used to instruct the serializer if a property has been set and thus should be included in the output XML have been made `protected` instead of `public`.
- Extension methods for `OcipClient` have been moved to the `BroadWorksConnector` namespace so they're in the same namespace as `OcipClient`.

### Fixed
- `OcipClient` now properly calls `Validator` on execution.

[2.1.2]: https://github.com/cwmiller/broadworks-connector-net/compare/2.1.1...2.1.2
[2.1.1]: https://github.com/cwmiller/broadworks-connector-net/compare/2.1.0...2.1.1
[2.1.0]: https://github.com/cwmiller/broadworks-connector-net/compare/2.0.1...2.1.0
[2.0.1]: https://github.com/cwmiller/broadworks-connector-net/compare/2.0.0...2.0.1
[2.0.0]: https://github.com/cwmiller/broadworks-connector-net/compare/1.4.0...2.0.0
[1.4.0]: https://github.com/cwmiller/broadworks-connector-net/compare/1.3.0...1.4.0
[1.3.0]: https://github.com/cwmiller/broadworks-connector-net/compare/1.2.0...1.3.0
[1.2.0]: https://github.com/cwmiller/broadworks-connector-net/compare/1.1.0...1.2.0
[1.1.0]: https://github.com/cwmiller/broadworks-connector-net/compare/1.0.3...1.1.0
[1.0.3]: https://github.com/cwmiller/broadworks-connector-net/compare/1.0.2...1.0.3
[1.0.2]: https://github.com/cwmiller/broadworks-connector-net/compare/1.0.1...1.0.2
[1.0.1]: https://github.com/cwmiller/broadworks-connector-net/compare/1.0.0...1.0.1
[1.0.0]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.5-alpha...1.0.0
[0.5.5-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.4-alpha...0.5.5-alpha
[0.5.4-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.3-alpha...0.5.4-alpha
[0.5.3-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.2-alpha...0.5.3-alpha
[0.5.2-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.1-alpha...0.5.2-alpha
[0.5.1-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.0-alpha...0.5.1-alpha
[0.5.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.4.2-alpha...0.5.0-alpha
[0.4.2-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.4.1-alpha...0.4.2-alpha
[0.4.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.3.0-alpha...0.4.0-alpha
[0.4.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.3.0-alpha...0.4.0-alpha