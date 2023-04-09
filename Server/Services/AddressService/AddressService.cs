namespace EComm.Server.Services.AddressService
{
	public class AddressService : IAddressService
	{
		private readonly DataContext _context;
		private readonly IAuthService _authService;

		public AddressService(DataContext context,
								IAuthService authService)
		{
			_context = context;
			_authService = authService;
		}

		public async Task<ServiceResponse<Address>> AddOrUpdateAddress(Address address)
		{
			var response = new ServiceResponse<Address>();
			var dbAddress = (await GetAddress()).Data;

			if (dbAddress == null)
			{
				address.UserId = _authService.GetUserId();
				_context.Addresses.Add(address);
				response.Data = address;
			}
			else
			{
				dbAddress.FirstName = dbAddress.FirstName;
				dbAddress.LastName = dbAddress.LastName;
				dbAddress.State = dbAddress.State;
				dbAddress.City = dbAddress.City;
				dbAddress.Country = dbAddress.Country;
				dbAddress.Zip = dbAddress.Zip;
				dbAddress.Street = dbAddress.Street;
				response.Data = dbAddress;
			}

			await _context.SaveChangesAsync();

			return response;
		}

		public async Task<ServiceResponse<Address>> GetAddress()
		{
			int userId = _authService.GetUserId();
			var address = await _context.Addresses.FirstOrDefaultAsync(a => a.UserId == userId);

			return new ServiceResponse<Address> { Data = address };
		}
	}
}
