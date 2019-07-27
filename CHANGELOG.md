# Changelog

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

[0.5.1-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.5.0-alpha...0.5.1-alpha
[0.5.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.4.2-alpha...0.5.0-alpha
[0.4.2-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.4.1-alpha...0.4.2-alpha
[0.4.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.3.0-alpha...0.4.0-alpha
[0.4.0-alpha]: https://github.com/cwmiller/broadworks-connector-net/compare/0.3.0-alpha...0.4.0-alpha