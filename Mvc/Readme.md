
List stored-procedure 

use devfast-mvc;


--- Find All ---

	DELIMITER //

	CREATE PROCEDURE GetAllBlogs()
	BEGIN
		SELECT *  FROM blog WHERE is_active = true;
	END //

	DELIMITER ;

--- Find By title ---

	DELIMITER //

	CREATE PROCEDURE GetAllBlogsByTitle(
		IN title VARCHAR(250)
	)
	BEGIN
		SELECT *  FROM blog WHERE title like LIKE CONCAT('%', title , '%');
	END //

	DELIMITER ;

--- update ---

	DELIMITER //

	CREATE PROCEDURE UpdateBlogs
	(
		IN Id int,
		IN Title VARCHAR(250),
		IN Short_Description VARCHAR(500),
		IN Description VARCHAR(5000),
		IN Img_Url VARCHAR(250),
		IN Category_Id int,
		IN Place VARCHAR(250),
		IN Status BOOLEAN
	)
	BEGIN
		UPDATE blog SET title = Title, short_desciption = Short_Description, description = Description, img_url = Img_Url,
				category_id= Category_Id, place = Place, status = status WHERE id = Id AND is_active = true;
	END //

	DELIMITER ;

--- delete ---

	DELIMITER //

	CREATE PROCEDURE DeleteBlogsById
	(
		IN BlogId int
	)
	BEGIN
		UPDATE blog SET is_active = false WHERE id = BlogId;
	END //

	DELIMITER ;

--- Insert -- 

	DELIMITER //

	CREATE PROCEDURE InsertBlog
	(
		IN Title VARCHAR(250),
		IN Short_Description VARCHAR(500),
		IN Description VARCHAR(5000),
		IN Img_Url VARCHAR(250),
		IN Category_Id int,
		IN Place VARCHAR(250),
		IN Status BOOLEAN
	)
	BEGIN
		SELECT *  FROM blog WHERE title like LIKE CONCAT('%', title , '%');
	END //

	DELIMITER ;
