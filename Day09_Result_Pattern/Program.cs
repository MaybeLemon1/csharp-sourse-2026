using Day09_Result_Pattern.Data.DataSources;
using Day09_Result_Pattern.Data.Models;
using Day09_Result_Pattern.Data.Repositores;
using Day09_Result_Pattern.Data.Common;
using Day09_Result_Pattern.Data.Common.Errors;

namespace Day09_Result_Pattern;

class Program
{
    static async Task Main(string[] args)
    {
        IPokemonApiDataSource dataSource = new PokemonApiDataSource(new HttpClient());
        IPokemonRepository repository = new PokemonRepository(dataSource);

        Result<Pokemon, PokemonError> result = await repository.GetPokemonByNameAsync("jigglypuff");
        
        switch (result)
        {
            case Result<Pokemon, PokemonError>.Success successResult:
                Console.WriteLine($"포켓몬 이름: {successResult.data.Name}");
                Console.WriteLine($"이미지URL: {successResult.data.ImageUrl}");
                break;
            case Result<Pokemon, PokemonError>.Error errorResult:
                switch (errorResult.error)
                {
                    case PokemonError.NotFound:
                        Console.WriteLine("오류: 해당 포켓몬을 찾을 수 없습니다.");
                        break;
                    case PokemonError.NetworkTimeout:
                        Console.WriteLine("오류: 네트워크 연결 시간 초과.");
                        break;
                    default:
                        Console.WriteLine("알 수 없는 오류가 발생했습니다.");
                        break;
                }
                break;
        }
    }
}