using SocialNetwork.DAL;
using SocialNetwork.Domain.DAL;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SocialNetwork.Forms
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
            
        }
        
        public void FillInUserInformation(string userId)
        {
            var userInfo = UsersDAL.GetUserById(userId);
            var postInfo = PostsDAL.GetUserPostsCount(userId);

            textBoxIdUser.Text = userId;
            tbUsernameProfile.Text = userInfo.Username; 
            tbFirstNameProfile.Text = userInfo.FirstName;   
            tbLastNameProfile.Text = userInfo.LastName;
            listBoxInterests.Items.AddRange(userInfo.Interests.ToArray());

            tbFollowersCount.Text = userInfo.Followers.Count.ToString();
            tbPostsCount.Text = postInfo.ToString();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            StartPages form = new StartPages();
            form.Show();
            this.Hide();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            
            textBoxIdUser.Hide();
            tabPagePosts.Hide();
            tabPageFollowers.Hide();
            tabPageProfile.Show();
            
        }

        private void buttonFollower_Click(object sender, EventArgs e)
        {
            tabPageProfile.Hide();
            tabPageFollowers.Show();
            var userId = textBoxIdUser.Text;
            var userFollowers = UsersDAL.GetFollowers(userId).ToArray();
            listBoxFollowers.Items.AddRange(userFollowers);
           
        }
        private void buttonNewFollow_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = textBoxIdUser.Text;
                var nameNewFriend = textBoxNewFriendFind.Text;
                var newFriendId = UsersDAL.FindUserProfile(nameNewFriend);
                if (UsersDAL.IsFollower(userId, newFriendId))
                {
                    MessageBox.Show($"You've already followed this person", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    UsersDAL.NewFollowUser(userId, newFriendId);
                    MessageBox.Show($"This person successful added to your followers", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            tabPageFollowers.Hide();
            tabPageProfile.Show();
            listBoxFollowers.Items.Clear();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            tabPageProfile.Hide();
            tabPagePosts.Show();

            var userId = textBoxIdUser.Text;
            var postsIdList = PostsDAL.GetPostsIdsByUserId(userId);

            listViewPosts.Columns.Add("Id");
            listViewPosts.Columns.Add("Content");
            listViewPosts.Columns.Add("Created Time");
            listViewPosts.Columns.Add("Comments");
            listViewPosts.Columns.Add("Reactions");

            foreach (var postId in postsIdList)
            {
                var postInfo = PostsDAL.GetPostById(postId);
                ListViewItem item = new ListViewItem(postId);
                item.SubItems.Add(postInfo.Id);
                item.SubItems.Add(postInfo.Content);
                item.SubItems.Add(postInfo.CreatedTime.ToString());
                item.SubItems.Add(postInfo.Comments.Count.ToString());
                item.SubItems.Add(postInfo.Reactions.Count.ToString());
                listViewPosts.Items.Add(item);
            }

        }

        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPosts.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPosts.SelectedItems[0];

                string postId = selectedItem.SubItems[0].Text;

                Posts post = PostsDAL.GetPostById(postId);

                tbContentPost.Text = post.Content;
                tbPostId.Text = post.Id.ToString();
                listBoxCommentsPost.Items.AddRange(post.Comments.ToArray());
            }
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                var newComment = tbCommentAdd.Text;
                var postId = tbPostId.Text;
                PostsDAL.AddComment(postId, newComment);
                MessageBox.Show($"Comment successful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLaugh_Click(object sender, EventArgs e)
        {
            var postId = tbPostId.Text;
            PostsDAL.UpdateReaction("Laugh", postId);
        }

        private void buttonHeart_Click(object sender, EventArgs e)
        {
            var postId = tbPostId.Text;
            PostsDAL.UpdateReaction("Heart", postId);
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            var postId = tbPostId.Text;
            PostsDAL.UpdateReaction("Like", postId);
        }

        private void buttonShowPosts_Click(object sender, EventArgs e)
        {
            tabPageFollowers.Hide();
            tabPagePosts.Show();

            var userId = textBoxIdUser.Text;
            var nameFriend = textBoxNewFriendFind.Text;
            var friendId = UsersDAL.FindUserProfile(nameFriend);


            var postsIdList = PostsDAL.GetPostsIdsByUserId(friendId);

            listViewPosts.Columns.Add("Id");
            listViewPosts.Columns.Add("Content");
            listViewPosts.Columns.Add("Created Time");
            listViewPosts.Columns.Add("Comments");
            listViewPosts.Columns.Add("Reactions");

            foreach (var postId in postsIdList)
            {
                var postInfo = PostsDAL.GetPostById(postId);
                ListViewItem item = new ListViewItem(postId);
                item.SubItems.Add(postInfo.Id);
                item.SubItems.Add(postInfo.Content);
                item.SubItems.Add(postInfo.CreatedTime.ToString());
                item.SubItems.Add(postInfo.Comments.Count.ToString());
                item.SubItems.Add(postInfo.Reactions.Count.ToString());
                listViewPosts.Items.Add(item);
            }

        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            tabPageProfile.Hide();
            tabPageAddPosts.Show();
        }

        private void buttonAddConcretePost_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = textBoxIdUser.Text;
                var content = tbAddPostContent.Text;
                List<string> comment = new List<string>();
                string currentComment = tbAddPostComment.Text;
                comment.Add(currentComment);
                PostsDAL.AddPost(userId, content, comment);
                MessageBox.Show($"Post successful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
