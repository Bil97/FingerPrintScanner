# FingerPrintScanner

Api sample
----------


[api url]
https://www.website/api/fingerprint


[get]
get_fingerprint(string userId) -> return fingerprint_for_the_given_userId;
// gets the saved fingerprint for the given userId and sends it to the app

[post]
register_fingerprint(string userId, string fingerprint)
// receives fingerprint for a given userId and saves it.

[post]
verify_fingerprint(string userId, bool verificationStatus)
// receives true if a given user's finger print is a match other wise it receives false



How to use the App
------------------

> when the app has launchedand the fingerprint scanner is connected, click on 'Initialize Device'

> to disconnect adevice click 'Disconnect Device'

> to register a new fingerprint, first add a unique id for the user (this can be the username, userId, email...; it should match the data that is set to be received at the api endpoint) in the Unique User Id field at the bottom, then add the url to the api that will receive the fingerprint data, then click 'Click To Enroll'

> to verify a registered fingerprint, first add a unique id for the user (this can be the username, userId, email...; it should match the data that is set to be sent by the api endpoint) in the Unique User Id field at the bottom, then add the url to the api that will send the fingerprint data, then click 'Verify'

> 'Free Resources' disconnects all connected devices
