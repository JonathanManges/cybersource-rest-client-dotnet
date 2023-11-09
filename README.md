# .NET Client SDK for the CyberSource REST API

The CyberSource .NET client provides convenient access to the [CyberSource REST API](https://developer.cybersource.com/api/reference/api-reference.html) from your .NET application.

## Requirements

* .NET Framework 4.6.1

## Installation

* Nuget Package Manager

```bash
PM>  Install-Package CyberSource.Rest.Client
```

## IMPORTANT FOR v0.0.1.30, v0.0.1.31, v0.0.1.32

CyberSource is aware of an issue with these versions of the SDK caused by the tight coupling of the version of RestSharp with the SDK. The packaging information has not been updated to reflect the correct constraints for RestSharp. 

**This issue will get resolved from the upcoming version onwards.**

To resolve the issue in these three versions, run the following command from the Package Manager Console:

`Install-Package RestSharp -Version 108.0.3`

You may also want to execute the following command to upgrade the Authentication SDK to the correct version:

`Install-Package CyberSource.Authentication -Version 0.0.0.16`

## Registration & Configuration

Use of this SDK and the CyberSource APIs requires having an account on our system. You can find details of getting a test account and creating your keys [here](https://developer.cybersource.com/api/developer-guides/dita-gettingstarted/registration.html)

Remember this SDK is for use in server-side .NET applications that access the CyberSource REST API and credentials should always be securely stored and accessed appropriately.

## SDK Usage Examples and Sample Code

To get started using this SDK, it's highly recommended to download our sample code repository:

* [Cybersource C# Sample Code Repository (on GitHub)](https://github.com/CyberSource/cybersource-rest-samples-csharp)

In that respository, we have comprehensive sample code for all common uses of our API:

Additionally, you can find details and examples of how our API is structured in our API Reference Guide:

* [Developer Center API Reference](https://developer.cybersource.com/api/reference/api-reference.html)

The API Reference Guide provides examples of what information is needed for a particular request and how that information would be formatted. Using those examples, you can easily determine what methods would be necessary to include that information in a request using this SDK.

## MetaKey Support

A Meta Key is a single key that can be used by one, some, or all merchants (or accounts, if created by a Portfolio user) in the portfolio.

The Portfolio or Parent Account owns the key and is considered the transaction submitter when a Meta Key is used, while the merchant owns the transaction.

MIDs continue to be able to create keys for themselves, even if a Meta Key is generated.

Further information on MetaKey can be found in [New Business Center User Guide](https://developer.cybersource.com/library/documentation/dev_guides/Business_Center/New_Business_Center_User_Guide.pdf).

## OAuth Support

OAuth enables service providers to securely share access to customer data without sharing password data.

The CyberSource OAuth2.0 Authorization Server (or API Auth Service) will issue access tokens (based on merchant user credentials) to CyberSource or third-party Applications. These applications can access CyberSource APIs on the merchant's behalf, using the access tokens.

During application registration, third-party application developers are issued a `client_id` and optionally a `client_secret` (if they can be considered a confidential client, for example a web application).

These values will be used when the merchant application wants to request an access token and/or a refresh token. This is explained in more detail in [Requesting the Access and Refresh Tokens](https://developer.cybersource.com/api/developer-guides/OAuth/cybs_extend_intro/obtaining_access_refresh_tokens.html).

For more detailed information on OAuth, refer to the documentation at [Cybersource OAuth 2.0](https://developer.cybersource.com/api/developer-guides/OAuth/cybs_extend_intro.html).

In order to use OAuth, set the run environment to OAuth enabled URLs. OAuth only works in these run environments.

```csharp
    // For TESTING use
    _configurationDictionary.Add("runEnvironment", "api-matest.cybersource.com")
    // For PRODUCTION use
    // _configurationDictionary.Add("runEnvironment", "api-ma.cybersource.com")
```

### Switching between the sandbox environment and the production environment

Cybersource maintains a complete sandbox environment for testing and development purposes. This sandbox environment is an exact duplicate of our production environment with the transaction authorization and settlement process simulated. By default, this SDK is configured to communicate with the sandbox environment. To switch to the production environment, set the `runEnvironment` property in the SDK Configuration.  See our sample at [the Configuration.cs class in the Sample Codes repository](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/master/src/Configuration.cs).

```csharp
    // For TESTING use
    _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
    // For PRODUCTION use
    // _configurationDictionary.Add("runEnvironment", "api.cybersource.com");
```

API credentials are different for each environment, so be sure to switch to the appropriate credentials when switching environments.

### Logging

[![Generic badge](https://img.shields.io/badge/LOGGING-NEW-GREEN.svg)](https://shields.io/)

Since v0.0.1.14, a new logging framework has been introduced in the SDK. This new logging framework makes use of NLog, and standardizes the logging so that it can be integrated with the logging in the client application.

More information about this new logging framework can be found in this file : [Logging.md](Logging.md)

## License

This repository is distributed under a proprietary license.

## Disclaimer

Cybersource may allow Customer to access, use, and/or test a Cybersource product or service that may still be in development or has not been market-tested (�Beta Product�) solely for the purpose of evaluating the functionality or marketability of the Beta Product (a �Beta Evaluation�). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer�s participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder): The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period (�Beta Product Form�). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer�s use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. Cybersource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided �AS IS� and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.
