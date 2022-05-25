using System;
using IdentityServer4.Models;

namespace IdentityServerAuthServer
{
	public static class Config
	{
		public static IEnumerable<ApiResource> GetApiResources()
        {
			return new List<ApiResource>()
			{
				new ApiResource("ResourceApi1")
				{
                    Scopes={"api1.read","api1.write","api1.update"}
				},
				new ApiResource("ResourceApi2")
				{
					Scopes={"api2.read","api2.write","api2.update"}
				}

			};
        }

		public static IEnumerable<ApiScope> GetApiScopes()
        {
			return new List<ApiScope>()
			{
				new ApiScope("api1.read","Api 1 Icin Okuma Izni"),
				new ApiScope("api1.write","Api 1 Icin Yazma Izni"),
				new ApiScope("api1.update","Api 1 Icin Guncelleme Izni"),
				new ApiScope("api2.read","Api 2 Icin read Izni"),
				new ApiScope("api2.write","Api 2 Icin write Izni"),
				new ApiScope("api2.update","Api 2 Icin Guncelleme Izni")
			};
        }

		public static IEnumerable<Client> GetClients()
        {
			return new List<Client>()
			{
				new Client()
				{
					ClientId="Client1",
					ClientName="Client1",
					ClientSecrets=new[]{new Secret("secret".Sha256())},
					AllowedGrantTypes=GrantTypes.ClientCredentials,
                    AllowedScopes={"api1.read" } 
				},
				new Client()
				{
					ClientId="Client2",
					ClientName="Client2",
					ClientSecrets=new[]{new Secret("secret".Sha256())},
					AllowedGrantTypes=GrantTypes.ClientCredentials,
					AllowedScopes={"api1.read","api2.write","api2.update" }
				}
			};
        }
	}
}

