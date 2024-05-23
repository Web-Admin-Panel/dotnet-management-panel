-- Inserting user data
INSERT INTO users (user_id, username, first_name, last_name, is_admin, referral, has_payments, last_payment, is_premium, account_level, last_activity, joined, language) VALUES
(1, 'user1', 'FirstName1', 'LastName1', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(2, 'user2', 'FirstName2', 'LastName2', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(3, 'user3', 'FirstName3', 'LastName3', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(4, 'user4', 'FirstName4', 'LastName4', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(5, 'user5', 'FirstName5', 'LastName5', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(6, 'user6', 'FirstName6', 'LastName6', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(7, 'user7', 'FirstName7', 'LastName7', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(8, 'user8', 'FirstName8', 'LastName8', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(9, 'user9', 'FirstName9', 'LastName9', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(10, 'user10', 'FirstName10', 'LastName10', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(11, 'user11', 'FirstName11', 'LastName11', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(12, 'user12', 'FirstName12', 'LastName12', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(13, 'user13', 'FirstName13', 'LastName13', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(14, 'user14', 'FirstName14', 'LastName14', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(15, 'user15', 'FirstName15', 'LastName15', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(16, 'user16', 'FirstName16', 'LastName16', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(17, 'user17', 'FirstName17', 'LastName17', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(18, 'user18', 'FirstName18', 'LastName18', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(19, 'user19', 'FirstName19', 'LastName19', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(20, 'user20', 'FirstName20', 'LastName20', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(21, 'user21', 'FirstName21', 'LastName21', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(22, 'user22', 'FirstName22', 'LastName22', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(23, 'user23', 'FirstName23', 'LastName23', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(24, 'user24', 'FirstName24','LastName24', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(25, 'user25', 'FirstName25', 'LastName25', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(26, 'user26', 'FirstName26', 'LastName26', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(27, 'user27', 'FirstName27', 'LastName27', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(28, 'user28', 'FirstName28', 'LastName28', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(29, 'user29', 'FirstName29', 'LastName29', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN'),
(30, 'user30', 'FirstName30', 'LastName30', FALSE, NULL, FALSE, NULL, FALSE, 1, NOW(), NOW(), 'EN');

-- Inserting admin data (selecting random users as admins)
INSERT INTO admins (user_id, admin_level) VALUES
                                              (1, 5),
                                              (2, 4),
                                              (3, 3); -- Assuming the first three users are admins for simplicity

-- Inserting topic data
INSERT INTO topics (topic_id, name, description, is_archived, created_at, updated_at) VALUES
                                                                                          ('T1', 'Mathematics', 'Field of study focused on structure and change.', FALSE, NOW(), NOW()),
                                                                                          ('T2', 'Science', 'Systematic enterprise that builds and organizes knowledge.', FALSE, NOW(), NOW()),
                                                                                          ('T3', 'History', 'Study of past events.', FALSE, NOW(), NOW()),
                                                                                          ('T4', 'Literature', 'Body of written works.', FALSE, NOW(), NOW()),
                                                                                          ('T5', 'Art', 'Expression of creative skill.', FALSE, NOW(), NOW());

-- Inserting course data
INSERT INTO courses (name, description, is_mini_course, price, is_archived, created_at, updated_at) VALUES
-- Courses for topic T1
('Algebra', 'Introduction to Algebra.', FALSE, 100.0, FALSE, NOW(), NOW()),
('Calculus', 'Introduction to Calculus.', FALSE, 120.0, FALSE, NOW(), NOW()),
('Geometry', 'Introduction to Geometry.', FALSE, 110.0, FALSE, NOW(), NOW()),
-- Courses for topic T2
('Physics', 'Introduction to Physics.', FALSE, 110.0, FALSE, NOW(), NOW()),
('Chemistry', 'Introduction to Chemistry.', FALSE, 115.0, FALSE, NOW(), NOW()),
('Biology', 'Introduction to Biology.', FALSE, 110.0, FALSE, NOW(), NOW()),
-- Courses for topic T3
('World History', 'Study of global historical events.', FALSE, 90.0, FALSE, NOW(), NOW()),
('American History', 'Study of historical events in America.', FALSE, 85.0, FALSE, NOW(), NOW()),
('Ancient History', 'Study of ancient civilizations.', FALSE, 95.0, FALSE, NOW(), NOW()),
-- Courses for topic T4
('Shakespearean Literature', 'Study of works by Shakespeare.', FALSE, 80.0, FALSE, NOW(), NOW()),
('Modern Literature', 'Study of contemporary literary works.', FALSE, 85.0, FALSE, NOW(), NOW()),
('Poetry', 'Study of poetic forms and structures.', FALSE, 75.0, FALSE, NOW(), NOW()),
-- Courses for topic T5
('Renaissance Art', 'Study of art during the Renaissance.', FALSE, 90.0, FALSE, NOW(), NOW()),
('Modern Art', 'Study of contemporary artistic expressions.', FALSE, 95.0, FALSE, NOW(), NOW()),
('Classic Art', 'Study of classic artistic styles.', FALSE, 85.0, FALSE, NOW(), NOW());

-- Mapping topics to courses (topic_course)
INSERT INTO topic_course (topic_id, course_id) VALUES
-- Mapping for topic T1
('T1', 1), -- Algebra
('T1', 2), -- Calculus
('T1', 3), -- Geometry
-- Mapping for topic T2
('T2', 4), -- Physics
('T2', 5), -- Chemistry
('T2', 6), -- Biology
-- Mapping for topic T3
('T3', 7), -- World History
('T3', 8), -- American History
('T3', 9), -- Ancient History
-- Mapping for topic T4
('T4', 10), -- Shakespearean Literature
('T4', 11), -- Modern Literature
('T4', 12), -- Poetry
-- Mapping for topic T5
('T5', 13), -- Renaissance Art
('T5', 14), -- Modern Art
('T5', 15); -- Classic Art

-- Mapping users to topics (user_topics)
INSERT INTO user_topics (user_id, topic_id) VALUES
    (1, 'T1'),
    (2, 'T2'),
    (3, 'T3'),
    (4, 'T4'),
    (5, 'T5'),
    (6, 'T1'),
    (7, 'T2'),
    (8, 'T3'),
    (9, 'T4'),
    (10, 'T5'),
    (11, 'T1'),
    (12, 'T2'),
    (13, 'T3'),
    (14, 'T4'),
    (15, 'T5'),
    (16, 'T1'),
    (17, 'T2'),
    (18, 'T3'),
    (19, 'T4'),
    (20, 'T5'),
    (21, 'T1'),
    (22, 'T2'),
    (23, 'T3'),
    (24, 'T4'),
    (25, 'T5'),
    (26, 'T1'),
    (27, 'T2'),
    (28, 'T3'),
    (29, 'T4'),
    (30, 'T5');
