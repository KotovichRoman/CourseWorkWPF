use Fischlify

create table users (
	user_id int identity(1,1) constraint users_pk primary key,
	user_login nvarchar(256) unique,
	user_nickname nvarchar(256) not null,
	user_password nvarchar (256) not null,
	user_status int default 0
)

create table playlists (
	playlist_id int identity(1,1) constraint playlists_pk primary key,
	user_id int constraint playlists_users_pk foreign key references users(user_id)
)

create table genres (
	genre_id int identity(1,1) constraint genres_pk primary key,
	genre_name nvarchar(256) unique
)

create table tracks (
	track_id int identity(1,1) constraint tracks_id primary key,
	track_name nvarchar(256) not null,
	track_link nvarchar(256),
	user_id int constraint tracks_users_pk foreign key references users(user_id),
	genre_id int constraint tracks_genres_pk foreign key references genres(genre_id),
	album_id int constraint tracks_albums_pk foreign key references albums(album_id)
)

create table albums (
	album_id int identity(1,1) constraint albums_pk primary key,
	album_name nvarchar(256) not null,
	album_image nvarchar(256),
	track_id int constraint albums_tracks_pk foreign key references tracks(track_id),
	user_id int constraint albums_users_pk foreign key references users(user_id)
)

create table tracks_playlists (
	id int identity constraint tracks_playlists_pk primary key,
	track_id int constraint tracks_playlists_tracks_pk foreign key references tracks(track_id),
	playlists_id int constraint tracks_playlists_playlists_pk foreign key references playlists(playlist_id)
)