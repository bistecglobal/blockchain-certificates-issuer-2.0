# Microsoft Entra Verified ID Developer Guide

Microsoft Entra Verified ID is a decentralized identity solution that allows developers to integrate secure and privacy-preserving identity management into their applications. This guide provides an overview of the basic functionalities, links, and references for developers interested in implementing Microsoft Entra Verified ID.

## Basic Functionalities

### Decentralized Identifiers (DIDs)

- DIDs are user-generated, self-owned, globally unique identifiers rooted in decentralized trust systems.
- They allow for greater assurance of immutability, censorship resistance, and tamper evasiveness.
- DIDs are created, owned, and controlled independently of any organization or government.

### Verifiable Credentials

- Verifiable credentials are data objects consisting of claims made by the issuer attesting information about a subject.
- They are identified by schema and include the DID issuer and subject.
- Verifiable credentials are signed with a DID to provide proof that a relying party (verifier) is attesting to information proving they are the owners of the credential.

### Microsoft Entra Verified ID Service

- An issuance and verification service in Azure that enables identity owners to generate, present, and verify claims.
- Supports W3C Verifiable Credentials signed with the did:web method.

## Links and References

- [Microsoft Entra Verified ID Documentation](https://docs.microsoft.com/en-us/azure/active-directory/verifiable-credentials/overview)
- [Microsoft Entra Verified ID GitHub Repository](https://github.com/Microsoft/Entra)
- [Decentralized Identity Foundation (DIF)](https://identity.foundation/)
- [W3C Verifiable Credentials Specification](https://www.w3.org/TR/vc-data-model/)
