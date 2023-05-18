import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TeDuEcommer',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44376/',
    redirectUri: baseUrl,
    clientId: 'TeDuEcommer_App',
    responseType: 'code',
    scope: 'offline_access TeDuEcommer',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44347',
      rootNamespace: 'TeDuEcommer',
    },
  },
} as Environment;
