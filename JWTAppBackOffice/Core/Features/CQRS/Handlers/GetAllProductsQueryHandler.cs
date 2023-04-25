using AutoMapper;
using JWTAppBackOffice.Core.Application.Interfaces;
using JWTAppBackOffice.Core.Domain;
using JWTAppBackOffice.Core.DTOs;
using JWTAppBackOffice.Core.Features.CQRS.Queries;
using MediatR;

namespace JWTAppBackOffice.Core.Features.CQRS.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Product> _repository;

        public GetAllProductsQueryHandler(IMapper mapper, IRepository<Product> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            List<Product> data = await _repository.GetAllASync();
            return _mapper.Map<List<ProductListDto>>(data);
        }
    }
}
