namespace Registration.Mapper.DTOs.Registration.Bible;
public record GetBibleDto(string Book, int Chapter, int[]? Verses);