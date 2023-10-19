namespace SocialNetwork.Forms
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUserPage = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.listBoxInterests = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonFollower = new System.Windows.Forms.Button();
            this.tbPostsCount = new System.Windows.Forms.TextBox();
            this.tbFollowersCount = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tbLastNameProfile = new System.Windows.Forms.TextBox();
            this.tbFirstNameProfile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsernameProfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.buttonLaugh = new System.Windows.Forms.Button();
            this.buttonHeart = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.tbPostId = new System.Windows.Forms.TextBox();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.tbCommentAdd = new System.Windows.Forms.TextBox();
            this.listBoxCommentsPost = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.Label();
            this.tbContentPost = new System.Windows.Forms.TextBox();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.tabPageAddPosts = new System.Windows.Forms.TabPage();
            this.tbAddPostContent = new System.Windows.Forms.TextBox();
            this.tabPageFollowers = new System.Windows.Forms.TabPage();
            this.buttonShowPosts = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNewFollow = new System.Windows.Forms.Button();
            this.textBoxNewFriendFind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxFollowers = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddPostComment = new System.Windows.Forms.TextBox();
            this.buttonAddConcretePost = new System.Windows.Forms.Button();
            this.tabUserPage.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.tabPageAddPosts.SuspendLayout();
            this.tabPageFollowers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUserPage
            // 
            this.tabUserPage.Controls.Add(this.tabPageProfile);
            this.tabUserPage.Controls.Add(this.tabPagePosts);
            this.tabUserPage.Controls.Add(this.tabPageAddPosts);
            this.tabUserPage.Controls.Add(this.tabPageFollowers);
            this.tabUserPage.Location = new System.Drawing.Point(12, 12);
            this.tabUserPage.Name = "tabUserPage";
            this.tabUserPage.SelectedIndex = 0;
            this.tabUserPage.Size = new System.Drawing.Size(763, 346);
            this.tabUserPage.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.buttonAddPost);
            this.tabPageProfile.Controls.Add(this.textBoxIdUser);
            this.tabPageProfile.Controls.Add(this.listBoxInterests);
            this.tabPageProfile.Controls.Add(this.buttonPost);
            this.tabPageProfile.Controls.Add(this.buttonFollower);
            this.tabPageProfile.Controls.Add(this.tbPostsCount);
            this.tabPageProfile.Controls.Add(this.tbFollowersCount);
            this.tabPageProfile.Controls.Add(this.buttonLogOut);
            this.tabPageProfile.Controls.Add(this.tbLastNameProfile);
            this.tabPageProfile.Controls.Add(this.tbFirstNameProfile);
            this.tabPageProfile.Controls.Add(this.label3);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.tbUsernameProfile);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(755, 320);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPost.Location = new System.Drawing.Point(540, 53);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(185, 30);
            this.buttonAddPost.TabIndex = 17;
            this.buttonAddPost.Text = "Add Post";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Location = new System.Drawing.Point(401, 281);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(210, 20);
            this.textBoxIdUser.TabIndex = 16;
            // 
            // listBoxInterests
            // 
            this.listBoxInterests.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInterests.FormattingEnabled = true;
            this.listBoxInterests.ItemHeight = 25;
            this.listBoxInterests.Location = new System.Drawing.Point(138, 154);
            this.listBoxInterests.Name = "listBoxInterests";
            this.listBoxInterests.Size = new System.Drawing.Size(296, 29);
            this.listBoxInterests.TabIndex = 15;
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPost.Location = new System.Drawing.Point(540, 6);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(100, 30);
            this.buttonPost.TabIndex = 14;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonFollower
            // 
            this.buttonFollower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFollower.Location = new System.Drawing.Point(324, 6);
            this.buttonFollower.Name = "buttonFollower";
            this.buttonFollower.Size = new System.Drawing.Size(100, 30);
            this.buttonFollower.TabIndex = 13;
            this.buttonFollower.Text = "Follower";
            this.buttonFollower.UseVisualStyleBackColor = true;
            this.buttonFollower.Click += new System.EventHandler(this.buttonFollower_Click);
            // 
            // tbPostsCount
            // 
            this.tbPostsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPostsCount.Location = new System.Drawing.Point(646, 6);
            this.tbPostsCount.Name = "tbPostsCount";
            this.tbPostsCount.ReadOnly = true;
            this.tbPostsCount.Size = new System.Drawing.Size(79, 30);
            this.tbPostsCount.TabIndex = 12;
            // 
            // tbFollowersCount
            // 
            this.tbFollowersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFollowersCount.Location = new System.Drawing.Point(430, 6);
            this.tbFollowersCount.Name = "tbFollowersCount";
            this.tbFollowersCount.ReadOnly = true;
            this.tbFollowersCount.Size = new System.Drawing.Size(79, 30);
            this.tbFollowersCount.TabIndex = 11;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(629, 274);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(106, 33);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // tbLastNameProfile
            // 
            this.tbLastNameProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastNameProfile.Location = new System.Drawing.Point(138, 102);
            this.tbLastNameProfile.Name = "tbLastNameProfile";
            this.tbLastNameProfile.ReadOnly = true;
            this.tbLastNameProfile.Size = new System.Drawing.Size(296, 30);
            this.tbLastNameProfile.TabIndex = 5;
            // 
            // tbFirstNameProfile
            // 
            this.tbFirstNameProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstNameProfile.Location = new System.Drawing.Point(138, 53);
            this.tbFirstNameProfile.Name = "tbFirstNameProfile";
            this.tbFirstNameProfile.ReadOnly = true;
            this.tbFirstNameProfile.Size = new System.Drawing.Size(296, 30);
            this.tbFirstNameProfile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // tbUsernameProfile
            // 
            this.tbUsernameProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsernameProfile.Location = new System.Drawing.Point(10, 6);
            this.tbUsernameProfile.Name = "tbUsernameProfile";
            this.tbUsernameProfile.ReadOnly = true;
            this.tbUsernameProfile.Size = new System.Drawing.Size(296, 30);
            this.tbUsernameProfile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.buttonLaugh);
            this.tabPagePosts.Controls.Add(this.buttonHeart);
            this.tabPagePosts.Controls.Add(this.buttonLike);
            this.tabPagePosts.Controls.Add(this.tbPostId);
            this.tabPagePosts.Controls.Add(this.buttonAddComment);
            this.tabPagePosts.Controls.Add(this.tbCommentAdd);
            this.tabPagePosts.Controls.Add(this.listBoxCommentsPost);
            this.tabPagePosts.Controls.Add(this.label6);
            this.tabPagePosts.Controls.Add(this.Comments);
            this.tabPagePosts.Controls.Add(this.tbContentPost);
            this.tabPagePosts.Controls.Add(this.listViewPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(755, 320);
            this.tabPagePosts.TabIndex = 1;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // buttonLaugh
            // 
            this.buttonLaugh.Location = new System.Drawing.Point(584, 256);
            this.buttonLaugh.Name = "buttonLaugh";
            this.buttonLaugh.Size = new System.Drawing.Size(103, 32);
            this.buttonLaugh.TabIndex = 11;
            this.buttonLaugh.Text = "Laugh";
            this.buttonLaugh.UseVisualStyleBackColor = true;
            this.buttonLaugh.Click += new System.EventHandler(this.buttonLaugh_Click);
            // 
            // buttonHeart
            // 
            this.buttonHeart.Location = new System.Drawing.Point(479, 256);
            this.buttonHeart.Name = "buttonHeart";
            this.buttonHeart.Size = new System.Drawing.Size(103, 32);
            this.buttonHeart.TabIndex = 10;
            this.buttonHeart.Text = "Heart";
            this.buttonHeart.UseVisualStyleBackColor = true;
            this.buttonHeart.Click += new System.EventHandler(this.buttonHeart_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(370, 256);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(103, 32);
            this.buttonLike.TabIndex = 9;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // tbPostId
            // 
            this.tbPostId.Location = new System.Drawing.Point(371, 60);
            this.tbPostId.Name = "tbPostId";
            this.tbPostId.Size = new System.Drawing.Size(315, 20);
            this.tbPostId.TabIndex = 8;
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(612, 175);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(74, 20);
            this.buttonAddComment.TabIndex = 7;
            this.buttonAddComment.Text = "Add";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // tbCommentAdd
            // 
            this.tbCommentAdd.Location = new System.Drawing.Point(372, 175);
            this.tbCommentAdd.Name = "tbCommentAdd";
            this.tbCommentAdd.Size = new System.Drawing.Size(225, 20);
            this.tbCommentAdd.TabIndex = 6;
            // 
            // listBoxCommentsPost
            // 
            this.listBoxCommentsPost.FormattingEnabled = true;
            this.listBoxCommentsPost.Location = new System.Drawing.Point(372, 127);
            this.listBoxCommentsPost.Name = "listBoxCommentsPost";
            this.listBoxCommentsPost.Size = new System.Drawing.Size(315, 30);
            this.listBoxCommentsPost.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(367, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Reaction";
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comments.Location = new System.Drawing.Point(367, 99);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(107, 25);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "Comments";
            // 
            // tbContentPost
            // 
            this.tbContentPost.Location = new System.Drawing.Point(372, 34);
            this.tbContentPost.Name = "tbContentPost";
            this.tbContentPost.Size = new System.Drawing.Size(315, 20);
            this.tbContentPost.TabIndex = 2;
            // 
            // listViewPosts
            // 
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.Location = new System.Drawing.Point(15, 16);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(296, 273);
            this.listViewPosts.TabIndex = 1;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Details;
            this.listViewPosts.SelectedIndexChanged += new System.EventHandler(this.listViewPosts_SelectedIndexChanged);
            // 
            // tabPageAddPosts
            // 
            this.tabPageAddPosts.Controls.Add(this.buttonAddConcretePost);
            this.tabPageAddPosts.Controls.Add(this.tbAddPostComment);
            this.tabPageAddPosts.Controls.Add(this.label8);
            this.tabPageAddPosts.Controls.Add(this.label7);
            this.tabPageAddPosts.Controls.Add(this.tbAddPostContent);
            this.tabPageAddPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddPosts.Name = "tabPageAddPosts";
            this.tabPageAddPosts.Size = new System.Drawing.Size(755, 320);
            this.tabPageAddPosts.TabIndex = 3;
            this.tabPageAddPosts.Text = "AddPosts";
            this.tabPageAddPosts.UseVisualStyleBackColor = true;
            // 
            // tbAddPostContent
            // 
            this.tbAddPostContent.Location = new System.Drawing.Point(3, 45);
            this.tbAddPostContent.Multiline = true;
            this.tbAddPostContent.Name = "tbAddPostContent";
            this.tbAddPostContent.Size = new System.Drawing.Size(259, 94);
            this.tbAddPostContent.TabIndex = 0;
            // 
            // tabPageFollowers
            // 
            this.tabPageFollowers.Controls.Add(this.buttonShowPosts);
            this.tabPageFollowers.Controls.Add(this.buttonReturn);
            this.tabPageFollowers.Controls.Add(this.buttonNewFollow);
            this.tabPageFollowers.Controls.Add(this.textBoxNewFriendFind);
            this.tabPageFollowers.Controls.Add(this.label5);
            this.tabPageFollowers.Controls.Add(this.label4);
            this.tabPageFollowers.Controls.Add(this.listBoxFollowers);
            this.tabPageFollowers.Location = new System.Drawing.Point(4, 22);
            this.tabPageFollowers.Name = "tabPageFollowers";
            this.tabPageFollowers.Size = new System.Drawing.Size(755, 320);
            this.tabPageFollowers.TabIndex = 2;
            this.tabPageFollowers.Text = "Followers";
            this.tabPageFollowers.UseVisualStyleBackColor = true;
            // 
            // buttonShowPosts
            // 
            this.buttonShowPosts.Location = new System.Drawing.Point(421, 96);
            this.buttonShowPosts.Name = "buttonShowPosts";
            this.buttonShowPosts.Size = new System.Drawing.Size(93, 27);
            this.buttonShowPosts.TabIndex = 6;
            this.buttonShowPosts.Text = "Show posts";
            this.buttonShowPosts.UseVisualStyleBackColor = true;
            this.buttonShowPosts.Click += new System.EventHandler(this.buttonShowPosts_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(642, 268);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 27);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonNewFollow
            // 
            this.buttonNewFollow.Location = new System.Drawing.Point(565, 96);
            this.buttonNewFollow.Name = "buttonNewFollow";
            this.buttonNewFollow.Size = new System.Drawing.Size(93, 27);
            this.buttonNewFollow.TabIndex = 4;
            this.buttonNewFollow.Text = "Follow";
            this.buttonNewFollow.UseVisualStyleBackColor = true;
            this.buttonNewFollow.Click += new System.EventHandler(this.buttonNewFollow_Click);
            // 
            // textBoxNewFriendFind
            // 
            this.textBoxNewFriendFind.Location = new System.Drawing.Point(416, 51);
            this.textBoxNewFriendFind.Name = "textBoxNewFriendFind";
            this.textBoxNewFriendFind.Size = new System.Drawing.Size(243, 20);
            this.textBoxNewFriendFind.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(411, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Find friend";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "You Follow:";
            // 
            // listBoxFollowers
            // 
            this.listBoxFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFollowers.FormattingEnabled = true;
            this.listBoxFollowers.ItemHeight = 25;
            this.listBoxFollowers.Location = new System.Drawing.Point(16, 41);
            this.listBoxFollowers.Name = "listBoxFollowers";
            this.listBoxFollowers.Size = new System.Drawing.Size(341, 254);
            this.listBoxFollowers.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(315, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Comment";
            // 
            // tbAddPostComment
            // 
            this.tbAddPostComment.Location = new System.Drawing.Point(320, 45);
            this.tbAddPostComment.Multiline = true;
            this.tbAddPostComment.Name = "tbAddPostComment";
            this.tbAddPostComment.Size = new System.Drawing.Size(259, 94);
            this.tbAddPostComment.TabIndex = 3;
            // 
            // buttonAddConcretePost
            // 
            this.buttonAddConcretePost.Location = new System.Drawing.Point(504, 165);
            this.buttonAddConcretePost.Name = "buttonAddConcretePost";
            this.buttonAddConcretePost.Size = new System.Drawing.Size(75, 23);
            this.buttonAddConcretePost.TabIndex = 4;
            this.buttonAddConcretePost.Text = "Add";
            this.buttonAddConcretePost.UseVisualStyleBackColor = true;
            this.buttonAddConcretePost.Click += new System.EventHandler(this.buttonAddConcretePost_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabUserPage);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.tabUserPage.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.tabPagePosts.ResumeLayout(false);
            this.tabPagePosts.PerformLayout();
            this.tabPageAddPosts.ResumeLayout(false);
            this.tabPageAddPosts.PerformLayout();
            this.tabPageFollowers.ResumeLayout(false);
            this.tabPageFollowers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUserPage;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TextBox tbLastNameProfile;
        private System.Windows.Forms.TextBox tbFirstNameProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TextBox tbPostsCount;
        private System.Windows.Forms.TextBox tbFollowersCount;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonFollower;
        private System.Windows.Forms.ListBox listBoxInterests;
        private System.Windows.Forms.TabPage tabPageFollowers;
        private System.Windows.Forms.ListBox listBoxFollowers;
        private System.Windows.Forms.Button buttonNewFollow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxNewFriendFind;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ListBox listBoxCommentsPost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.TextBox tbContentPost;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.TextBox tbCommentAdd;
        private System.Windows.Forms.TextBox tbPostId;
        private System.Windows.Forms.Button buttonLaugh;
        private System.Windows.Forms.Button buttonHeart;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonShowPosts;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.TabPage tabPageAddPosts;
        private System.Windows.Forms.TextBox tbAddPostContent;
        private System.Windows.Forms.Button buttonAddConcretePost;
        private System.Windows.Forms.TextBox tbAddPostComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}