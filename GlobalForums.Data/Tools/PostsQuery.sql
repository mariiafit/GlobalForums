USE GlobalForums;

INSERT INTO Posts(Content, Created, ForumId, Title, UserId)
VALUES
('First Python Post Content Here...... !',GETDATE(),1,'First Python Post!', 'f674c850-cb1c-44f0-a303-37b8462446a3'),
('Second Python Post... !',GETDATE(),1,'Another Python Post!', 'f674c850-cb1c-44f0-a303-37b8462446a3'),
('More Python',GETDATE(),1,'Python For Machine Learning', 'f674c850-cb1c-44f0-a303-37b8462446a3'),
('More Content',GETDATE(),1,'Using Matplotlib', 'f674c850-cb1c-44f0-a303-37b8462446a3');

--SELECT * FROM AspNetUsers;

/*SELECT p.Title AS PostTitle, f.Title AS ForumName
FROM Posts p 
	INNER JOIN Forums f ON p.ForumId = f.Id
	INNER JOIN AspNetUsers u ON u.Id = p.UserId
WHERE p.Id = 1;/*