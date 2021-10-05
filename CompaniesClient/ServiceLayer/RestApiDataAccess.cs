﻿using CompaniesClient.DTO;
using DataAccessLayer;
using RestSharp;
using System;
using System.Collections.Generic;

namespace CompaniesClient.ServiceLayer
{
    public class RestApiDataAccess : ICompanyService
    {
        public string BaseUri { get; private set; }

        private RestClient RestClient { get; set; }

        public RestApiDataAccess(string baseUri)
        {
            BaseUri = baseUri;
            RestClient = new RestClient(baseUri);
        }

        public int AddCompany(Company company)
        {
            var request = new RestRequest();
            request.AddJsonBody(company);
            return RestClient.Post<int>(request).Data;
        }

        public bool DeleteCompany(int id)
        {
            var request = new RestRequest(id.ToString());
            var response = RestClient.Delete<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error deleting account with id {id}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }
        public IEnumerable<Company> GetAll()
        {
            return RestClient.Execute<IEnumerable<Company>>(new RestRequest()).Data;
        }

        public Company GetCompanyById(int id)
        {
            var request = new RestRequest(id.ToString());
            return RestClient.Execute<Company>(request).Data;
        }

        public Company GetCompanyByPartOfName(string partOfCompanyName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompany(Company company)
        {
            var request = new RestRequest();
            request.AddJsonBody(company);
            var response = RestClient.Put<bool>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error updating company {company}. Message was {response.StatusDescription}");
            }
            return response.Data;
        }
    }
}
