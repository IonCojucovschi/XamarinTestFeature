﻿using System;
using System.Threading.Tasks;
using StartupCore.Constants;
using StartupCore.Contracts.Repository;
using StartupCore.Contracts.Services.Data;
using StartupCore.Contracts.Services.General;
using StartupCore.Models;

namespace StartupCore.Services.Data
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IGenericRepository _genericRepository;
        private readonly ISettingsService _settingsService;
        public AuthenticationService(IGenericRepository genericRepository, ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _genericRepository = genericRepository;

        }

        public async Task<AuthenticationResponse> Register(string firstName, string lastName, string email, string login, string password)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.PostLogin
            };

            AuthenticationRequest authenticationRequest = new AuthenticationRequest()
            {
                ///Email = email,
                //FirstName = firstName,
                //LastName = lastName,
                //UserName = userName,
                Password = password,
                Login = login

            };

            return await _genericRepository.PostAsync<AuthenticationRequest, AuthenticationResponse>(builder.ToString(), authenticationRequest);
        }

        public bool IsUserAuthenticated()
        {
            return !string.IsNullOrEmpty(_settingsService.UserIdSetting);
        }

        public async Task<AuthenticationResponse> Authenticate(string userName, string password)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.PostLogin
            };


            AuthenticationRequest authenticationRequest = new AuthenticationRequest()
            {
                UserName = userName,
                Password = password
            };
            string requestUrl = builder.ToString() + "admin/password/admin";
            return await _genericRepository.PostAsync<AuthenticationRequest, AuthenticationResponse>(requestUrl, authenticationRequest);
        }
    }
}
