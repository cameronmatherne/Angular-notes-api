﻿namespace notes_api.Models;
using Microsoft.EntityFrameworkCore;


public class NoteContext : DbContext
{
    public NoteContext(DbContextOptions<NoteContext> options)
        : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; } = null!;
}