# Steam Account Checker

Author: [swooshXE](https://github.com/swooshXE/)

Edited and Update: [KingNNT](https://github.com/KingNNT/)

🔥 Check your Steam accounts to see if they are created and SteamGuard protected within seconds

## Development

This version of SAC will most likely not be updated as I'm working on a V2. I'm developing my own set of tools (sxetools) and SAC V2 will be part of it.

---

## What can you do:

### Manual check

-   Write a Steam username and password and hit 'Check for accounts'

### Automatic check

-   Open a file that contains the formatting stated below:

```
username:password
username:password
username:password
username:password
...
```

-   Hit 'Check for accounts'

### Status messages:

-   **«nothing»** - Successfully connected to account
-   **SteamGuard protected** - The account EXISTS but in order to log in, you must verify it with its associated e-mail address
-   **InvalidPassword** - The account doesn't exist (or mispelled something)
-   **RateLimitExceeded** - You've checked too many accounts in a short period of time - Adding proxys in V2
-   **ServiceUnavailable** - Couldn't connect to Steam servers (it's probably down)
