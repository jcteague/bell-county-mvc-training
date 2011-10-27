require 'bin/mvc-training.dll'
include  MvcTraining::Domain
include  MvcTraining::Services

def load_users
repo = FileRepository[MvcTraining::Domain::User].new File.dirname(__FILE__)

repo.save User.new(1,"John")
repo.save User.new(2,"Paul")
repo.save User.new(3,"George")
repo.save User.new(4,"Ringo")

end

load_users