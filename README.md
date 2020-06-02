# SE.GOV.MM.Integration
Some unofficial classes to help setup postal service for Mina Meddelanden (MM)

This project have the following methods utilize:
* <b>distributeSecure</b> - Handles sending message to user.
* <b>IsValidSignature</b> - Validates if xmldocument contains a valid signature
* <b>IsUserReachableInFaRV3</b> - Checks if recipient is reachable in FaR
* <b>GetSenders</b> - Gets all registered senders

DistributeSecure uses IsValidSignature, IsUserReachableInFaRV3, GetSenders for validationg before sending message to recipient.

This is one of the superimposed <b>distributeSecure</b>:

```c#
public DeliveryResult distributeSecure(SignedDelivery SignedDelivery, string endpointAdressRecipient, string endpointAdressAuthority, X509Certificate2 x509Certificate2){}
```
where
- SignedDelivery -  Message to send. If signature is missing, message is signed and sent
- endpointAdressRecipient - Endpoint to send recipient request <https://notarealhost.skatteverket.se/webservice/acc1accao/Recipient/v3>
- endpointAdressAuthority - Endpoint to send authority request <https://notarealhost.skatteverket.se/webservice/acc1accao/Authority>
- x509Certificate2 - Certificate to sign with
