class Author < ApplicationRecord
  has_many :books, dependent: :destroy
end

class Book < ApplicationRecord
  belongs_to :author
end

@book = @author.books.create(published_at: Time.now)
@author.destroy