-- Creating the users table
CREATE TABLE users (
                       user_id BIGINT PRIMARY KEY,
                       username VARCHAR,
                       first_name VARCHAR,
                       last_name VARCHAR,
                       is_admin BOOLEAN DEFAULT FALSE,
                       referral BIGINT DEFAULT NULL,
                       has_payments BOOLEAN DEFAULT FALSE,
                       last_payment TIMESTAMPTZ DEFAULT NULL,
                       is_premium BOOLEAN DEFAULT FALSE,
                       account_level BIGINT DEFAULT 0,
                       last_activity TIMESTAMPTZ DEFAULT NOW(),
                       joined TIMESTAMPTZ DEFAULT NOW(),
                       language VARCHAR
);

-- Creating the topics table
CREATE TABLE topics (
                        topic_id VARCHAR PRIMARY KEY,
                        name VARCHAR,
                        description VARCHAR DEFAULT '',
                        is_archived BOOLEAN DEFAULT FALSE,
                        created_at TIMESTAMPTZ DEFAULT NOW(),
                        updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- Creating the courses table
CREATE TABLE courses (
                         course_id SERIAL PRIMARY KEY,
                         name VARCHAR,
                         description VARCHAR,
                         is_mini_course BOOLEAN,
                         price FLOAT,
                         is_archived BOOLEAN,
                         created_at TIMESTAMPTZ DEFAULT NOW(),
                         updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- Creating the topic_course table
CREATE TABLE topic_course (
                              topic_id VARCHAR,
                              course_id INT,
                              PRIMARY KEY (topic_id, course_id),
                              FOREIGN KEY (topic_id) REFERENCES topics(topic_id) ON DELETE CASCADE,
                              FOREIGN KEY (course_id) REFERENCES courses(course_id) ON DELETE CASCADE
);

-- Creating the user_topics table
CREATE TABLE user_topics (
                             user_id BIGINT,
                             topic_id VARCHAR,
                             PRIMARY KEY (user_id, topic_id),
                             FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
                             FOREIGN KEY (topic_id) REFERENCES topics(topic_id) ON DELETE CASCADE
);

-- Creating the admins table
CREATE TABLE admins (
                        user_id BIGINT,
                        admin_level INT,
                        created_at TIMESTAMPTZ DEFAULT NOW(),
                        updated_at TIMESTAMPTZ DEFAULT NOW(),
                        PRIMARY KEY (user_id),
                        FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
);
