using Mapster;

namespace MovieStoreC.MapConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<Movie, AddMovieRequest>
                .TwoWays();
                .NewConfig();
        }
    }
}
