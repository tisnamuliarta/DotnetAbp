import { UserManager, UserManagerSettings } from 'oidc-client';

const settings: UserManagerSettings = {
    authority: process.env.NEXT_PUBLIC_API_URL,
    client_id: 'DotnetAbp_App',
    redirect_uri: 'http://localhost:3000/callback',
    post_logout_redirect_uri: 'http://localhost:3000',
    response_type: 'code',
    scope: 'offline_access DotnetAbp',
    filterProtocolClaims: true,
    loadUserInfo: true,
};

const userManager = new UserManager(settings);

export { userManager };